#pragma once
using namespace System;
using namespace System::Collections::Generic;

namespace SecretSharingCore
{
	namespace Common
	{
		public interface class IShare : IDisposable {
		public:
			int GetX();
			unsigned long GetY();
			String^ ToString();
		};
		public interface class ISecretShare {
		public:
			/*List<IShareCollection^>^ DivideSecret(int K, int N, String^ Secret);
			//List<IShare^>^ DivideSecret(int K, int N, long Secret);
			long ReconstructSecret(List<IShareCollection^>^ Shares);
			long GetPrime();*/
		};
	}
}